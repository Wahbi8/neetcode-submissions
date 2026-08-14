func productExceptSelf(nums []int) []int {
    n := len(nums)

    prefix := make([]int, n)
    postfix := make([]int, n)
    output := make([]int, n)

    prefix[0] = 1
    for i := 1; i < n; i++ {
        prefix[i] = prefix[i-1] * nums[i-1]
    }

    postfix[n-1] = 1
    for i := n - 2; i >= 0; i-- {
        postfix[i] = postfix[i+1] * nums[i+1]
    }

    for i := 0; i < n; i++ {
        output[i] = prefix[i] * postfix[i]
    }

    return output
}
