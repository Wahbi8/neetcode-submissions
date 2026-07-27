func groupAnagrams(strs []string) [][]string {
    data := make(map[int]map[rune]int)
    res := [][]string{}
    used := make([]bool, len(strs))

    for i := 0; i < len(strs); i++ {
        data[i] = make(map[rune]int)
        for _, char := range strs[i] {
            data[i][char]++
        }
    }

    for i := 0; i < len(strs); i++ {
        if used[i] {
            continue
        }
        used[i] = true
        res = append(res, []string{strs[i]})

        for j := i + 1; j < len(strs); j++ {
            if used[j] {
                continue
            }

            same := true

            if len(data[i]) != len(data[j]) {
                continue
            }

            for char, count := range data[i] {
                if data[j][char] != count {
                    same = false
                    break
                }
            }

            if same {
                res[len(res)-1] = append(res[len(res)-1], strs[j])
                used[j] = true
            }
        }
    }

    return res
}