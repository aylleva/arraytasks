//task1
int[] nums = { 43788,748329,962737,8575,78 };
int min = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] < min)
     
    {
        min = nums[i];
       
    }
    
}
Console.WriteLine(min);


