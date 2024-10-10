/*
1. 값 형식과 참조 형식의 차이점.
2. 박싱과 언박싱
3. StringBuilder VS string
4. 배열
- 학생성적 입력받아 배열에 저장
- 입력된 성적중 가장 높은 성적과 낮은 성적 출력
- 평균 성적 계산
- 오름차순 정렬
4.1 월남뽕

5.문자열 내 단어 뒤집기
- 문자열을 입력받고 해당 문자열의 각 단어를 뒤집는다.
입력예시)"abcd efgh"
출력예시)dcba hgfe
*/

using System.Runtime.InteropServices;

namespace Homework
{
	internal class Program
	{
		static void Homework1()
		{
			int[] scores = new int[5];
			int sum = 0;
			for (int i = 0; i < scores.Length; i++)
			{
				scores[i] = int.Parse(Console.ReadLine());
				sum += scores[i];
			}
			// 정렬함수
			Array.Sort(scores);
			Console.WriteLine($"최대값 : {scores.Max()}");
			Console.WriteLine($"최소값 : {scores.Min()}");
			Console.WriteLine($"평균 : {sum / scores.Length}");
			Console.Write("오름차순 정렬 : ");
			for (int i = 0; i < scores.Length; i++)
			{
				Console.Write($"{scores[i]} ");

			}
		}
		static void Homework2()
		{

		}
		static void Homework3()
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
			Homework3();
		}
	}
}