class Solution {

    public String encode(List<String> strs) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < strs.size(); i++) {
            for (int j = 0; j < strs.get(i).length(); j++) {
                result.append(strs.get(i).charAt(j));
            }
            result.append("/");
        }
        return result.toString();
    }

    public List<String> decode(String str) {
        List<String> result = new LinkedList<>();
        StringBuilder current = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == '/') {
                result.add(current.toString());
                current = new StringBuilder();
            } else {
                current.append(str.charAt(i));
            }
        }
        return result;
    }
}
