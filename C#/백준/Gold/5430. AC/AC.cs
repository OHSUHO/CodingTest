using System.Text;

class Program
{
    static void Main()
    {
        int caseNum = int.Parse(Console.ReadLine());
        for(int i=0; i < caseNum; i++)
        {
            string commend = Console.ReadLine();
            int arrayNum = int.Parse(Console.ReadLine());
            string array = Console.ReadLine();
            bool toggle = true; //정방향일때, true
            int fowardDelete = 0;
            int lastDelete = 0;
            for(int j=0; j < commend.Length; j++)
            {
                if(commend[j]=='R')
                {
                    toggle = !toggle;
                }
                if(commend[j]=='D')
                {
                    if(toggle)
                    {
                        fowardDelete += 1;
                    }
                    else
                    {
                        lastDelete += 1;
                    }
                }
            }
            if(fowardDelete+lastDelete > arrayNum)
            {
                Console.WriteLine("error");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                array = array.Substring(1,array.Length-2);
                if (!string.IsNullOrWhiteSpace(array))
                {
                    int[] intArr = array.Split(',').Select(x => int.Parse(x)).ToArray();
                    if(toggle)
                    {
                        for(int k=fowardDelete; k < intArr.Length-lastDelete;k++ )
                        {
                            sb.Append(intArr[k].ToString());
                            if(k!=intArr.Length-lastDelete-1)
                                sb.Append(',');
                        }
                  
                    }
                    else
                    {
                        Array.Reverse(intArr);
                 
                        for(int k=lastDelete; k < intArr.Length-fowardDelete;k++ )
                        {
                            sb.Append(intArr[k].ToString());
                            if(k!=intArr.Length-fowardDelete-1)
                                sb.Append(',');
                        }
                    
                    }
                    
                }
                sb.Append(']');
                Console.WriteLine(sb.ToString());
            }
        }

            
            
     }
        
        
        
        
        
        
        
        
}    
    
