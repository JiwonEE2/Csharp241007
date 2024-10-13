/*
[ 과제 3 ]
문자열 내 단어 뒤집기
- 문자열을 입력받고 해당 문자열의 각 단어를 뒤집는다.
입력예시)"abcd efgh"
출력예시)dcba hgfe
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	internal class Homework3
	{
		static void Homework()
		{
			// 문장 입력 받기
			// sentence = "abcd efgh"
			string sentence = Console.ReadLine();
			// 띄어쓰기로(단어단위로) 쪼개기
			// words[0] = "abcd", words[1] = "efgh"
			string[] words = sentence.Split(' ');
			// 단어 개수만큼 반복
			// words[0], words[1]을 char형으로 변경하고, 뒤집기
			string[] newWords = new string[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				// words[i]를 char형으로 변경
				char[] chars = words[i].ToCharArray();
				// 뒤집기
				Array.Reverse(chars);
				newWords[i] = chars.ToString();
				Console.Write(chars);
				Console.Write(' ');
			}
		}
		static void Main(string[] args)
		{
			Homework();
		}
	}
}