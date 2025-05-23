class Program
{
    static void Main()
    {
        string Input = Console.ReadLine();
        int[] k = Input.Split(' ').Select(int.Parse).ToArray();
        int N = k[0];
        int J = k[1];
        int S = k[2];
        int H = k[3];
        int K = k[4];

        int highObstacle = 0;
        int middleObstacle = 0;
        int lowObstacle = 0;

        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        string str3 = Console.ReadLine(); // 장애물 입력받기



        for (int j = 0; j < N; j++) // 장애물 검출을 위한 반복문
        {
            if (str1[j].ToString()=="v")
            {
                highObstacle++;
            }

            if (str2[j].ToString()=="^")
            {
                middleObstacle++;
            }

            if (str3[j].ToString()=="^")
            {
                lowObstacle++;
            }

        }

        lowObstacle -= middleObstacle; // 장애물 입력 받는방법 => low는 middle과 low가 중복이므로 middle을 제외
        S -= highObstacle; // 슬라이딩 횟수 - 높은장애물횟수 => 음수면 슬라이딩 개수가 모자람
        J -= lowObstacle; // 점프횟수 - 낮은장애물횟수 => 음수면 점프 모자람
        middleObstacle *= 2; // 중간장애물은 점프가 2번필요하므로 2를곱함.
        if (S < 0)
        {
            H += (S * K); // 높은장애물로 인한 데미지를 받는다.
        }

        if (J < 0)
        {
            H += (J * K); // 낮은장애물로 인한 데미지를 받는다.
            
            J = 0; // 데미지를 받았으니 초기화.
        }
        J -= middleObstacle;
        if (J < 0)
        {
            H += (J / 2) * K; //높은 장애물로 인한 데미지를 받는다.
            if (J % 2 == -1)
            {
                H -= K;
            }
        }

        Console.WriteLine(H<=0?-1:H);//H가 0보다 작거나 같으면 -1, 아니면 H를 출력 


    }
        
        
        
        
        
        
        
        
}    
    
