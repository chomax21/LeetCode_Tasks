// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Solution solution = new Solution();
solution.DeleteNums(new []{ 2 }, 3);
Console.WriteLine("Second solutions " + solution.DelNums(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));


public class Solution 
{
    public int DelNums(int[] nums, int val)
    {
        int j = 0;
        int cnt = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                cnt++;
            }
            else
            {
                nums[j++] = nums[i];
            }
        }
        return nums.Length - cnt;
    }

    public int DeleteNums(int[] nums, int val)
    {
        var match = Array.Find(nums, x => x == val);
        if(match == 0)
        {
            return 0;
        }
       
        int take = 0;
        int back = nums.Length - 1;
        for (int i = 0; i < back; i++)
        {
            if (nums[i] == val)
            {
                take++;
                if (nums[back] == nums[i])
                {
                    int temp = nums[back - 1];
                    nums[back - 1] = nums[i];
                    nums[i] = temp;
                    back -= 2;
                }
                else
                {
                    int temp = nums[back];
                    nums[back] = nums[i];
                    nums[i] = temp;
                    back--;
                }

            }
        }

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n" + (nums.Length - 1 - take));
        return (nums.Length -1) - take;
    }
}
