type Solution struct{}

func (s *Solution) Encode(strs []string) string {
    var encoded string
    for _, str := range strs {
        encoded += strconv.Itoa(len(str)) + "#" + str
    }

    return encoded
}

func (s *Solution) Decode(encoded string) []string {
    var strs []string

    i := 0
	for i < len(encoded) {
		j := i
		for encoded[j] != '#' {
			j++
		}

		length, _ := strconv.Atoi(encoded[i:j])

		j++

		strs = append(strs, encoded[j:j+length])
		i = j + length
	}
    return strs
}
