func topKFrequent(nums []int, k int) []int {
    data := make([][]int, len(nums)+1)
    dataCount := make(map[int]int)
    var res []int

    for _, num := range nums {
        dataCount[num]++
    }

    for num, freq := range dataCount {
        data[freq] = append(data[freq], num)
    }

    for i := len(data) - 1; i > 0; i-- {
        for _, num := range data[i] {
            res = append(res, num)

            if len(res) == k {
                return res
            }
        }
    }

    return res
}