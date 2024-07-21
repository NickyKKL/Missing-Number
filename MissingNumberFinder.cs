namespace MissingNumber;
public class MissingNumberFinder
{ 
    public static int Finder(int[] nums) {
        int index = 0;
        Array.Sort(nums);
        foreach (var num in nums) {
            if (num != index)
                return index;
            index++;
        }
        return index;
    }
}
