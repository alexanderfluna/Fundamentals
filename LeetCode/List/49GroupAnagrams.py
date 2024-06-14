class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        dictionary = defaultdict(list)

        for word in strs:
            sorted_word = ''.join(sorted(word))
            dictionary[sorted_word].append(word)

        return list(dictionary.values())