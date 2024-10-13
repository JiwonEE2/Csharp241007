/*
[ 과제 1 ]
배열
- 학생성적 입력받아 배열에 저장
- 입력된 성적중 가장 높은 성적과 낮은 성적 출력
- 평균 성적 계산
- 오름차순 정렬
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	internal class Homework1
	{
		static void Homework()
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
		static void Main(string[] args)
		{
			Homework();
		}
	}
}