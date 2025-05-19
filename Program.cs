//*****************************************************************************
//** 3024. Type of Triangle                                         leetcode **
//*****************************************************************************

char* triangleType(int* nums, int numsSize) {
    int a, b, c;
    a = nums[0];
    b = nums[1];
    c = nums[2];

    // Triangle inequality and non-positive side check
    if (a <= 0 || b <= 0 || c <= 0 ||
        a + b <= c || a + c <= b || b + c <= a)
    {
        return "none";
    }

    // Check triangle type
    if (a == b && b == c)
    {
        return "equilateral";
    }
    else if (a == b || b == c || c == a)
    {
        return "isosceles";
    }
    else
    {
        return "scalene";
    }
}