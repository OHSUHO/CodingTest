class Solution {
    public int solution(int[][] sizes) {

        int max_w_size = 1;
        int max_h_size = 1;
        for(int i=0; i < sizes.length; i++)
        {
            int temp_one =sizes[i][0];
            int temp_two = sizes[i][1];
            
            int temp_big = Math.max(temp_one,temp_two);
            int temp_small = Math.min(temp_one,temp_two);
            
            max_w_size = Math.max(max_w_size, temp_big);
            max_h_size = Math.max(max_h_size, temp_small);
        }
        int answer = max_w_size * max_h_size;
        return answer;
    }
}