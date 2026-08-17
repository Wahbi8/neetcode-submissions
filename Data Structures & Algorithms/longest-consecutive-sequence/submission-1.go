func longestConsecutive(nums []int) int {
    set := make(map[int]bool)

    for _, num := range nums {
        set[num] = true
    }

    length := 0
    for i := range set {
        if !set[i-1] {
            current := i
            currentLength := 1

            for set[current+1] {
                current++
                currentLength++
            }

            if currentLength > length {
                length = currentLength
            }
        }
    }
    return length
}
