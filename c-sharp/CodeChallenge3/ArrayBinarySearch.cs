namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] array, int key)
    {
      // Initialize the left boundary of the search range
      int left = 0;
      // Initialize the right boundary of the search range
      int right = array.Length - 1;

      // Continue the loop as long as the left boundary is less than or equal to the right boundary
      while (left <= right) 
      {
        // Calculate the middle index of the current search range
        int mid = left + (right - left) / 2;
        // If the middle element is equal to the key, we've found the target element
        if (array[mid] == key) 
        {
          // Return the index of the target element
          return mid; 
        }
        // If the key is greater than the middle element, narrow the search range to the right half
        else if (array[mid] < key) 
        {
          // Update the left boundary
          left = mid + 1;
        }
        // If the key is less than the middle element, narrow the search range to the left half
        else
        {
          // Update the right boundary
          right = mid - 1;
        }
      }

      return -1; // The key was not found, so return -1
    }
  }
}
