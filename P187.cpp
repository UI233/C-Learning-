class Node {
public:
    bool tail;
    int count;
    Node* ch[4];
    Node() {
        tail = false;
        count = 0;
        for (int i = 0; i < 4; ++i) {
            ch[i] = nullptr;
        }

    }
};

class Trie {
public:
    Node root;
    char code2ch(int v) {
         switch (v) {
            case 0:
                return 'A';
            case 1: 
                return 'C';
            case 2:
                return 'T';
            case 3:
                return 'G';
            default:
                return 0;
         }
    }

    int ch2code(char c) {
        switch (c) {
            case 'A':
                return 0;
            case 'C': 
                return 1;
            case 'T':
                return 2;
            case 'G':
                return 3;
            default:
                return -1;
        }
    }
    string insert(string s) {
        Node *now = &root;
        for (int i = 0; i < s.length(); ++i) {
            if (!now-> ch[ch2code(s[i])])
                now -> ch[ch2code(s[i])] = new Node();
            now = now -> ch[ch2code(s[i])];
        }

        now -> count++;
        now -> tail = true;
        if (now -> count == 2)
            return s;
        else return "";
    }
};

class Solution {
public:
    vector<string> findRepeatedDnaSequences(string s) {
        Trie temp;
        vector<string> ans;
        for (int i = 0; i <= (int)s.length() - 10; ++i)  {
            auto res = temp.insert(s.substr(i, 10));
            if (res != "")
                ans.push_back(res);
        }
        return ans;
    }
};