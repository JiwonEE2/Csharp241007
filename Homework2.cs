/*
[ 과제 2 ]
월남뽕
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	internal class Homework2
	{
		class Card
		{
			public int index { get; set; }
			public int num { get; set; }
			public string shape { get; set; }
		}
		static void Homework()
		{
			// 1~52까지의 카드. 13장씩 모양이 바뀜
			// 처음에 셔플해두기
			Random random = new Random();
			Card[] cards = new Card[52];
			for (int i = 0; i < 52; i++)
			{
				cards[i]
				if (i < 13)
				{
					cards[i].num = i + 1;
					cards[i].shape = "♠";
				}
				else if (i < 26)
				{
					cards[i].num = i + 1 - 13;
					cards[i].shape = "♥";
				}
				else if (i < 39)
				{
					cards[i].num = i + 1 - 26;
					cards[i].shape = "◆";
				}
				else
				{
					cards[i].num = i + 1 - 39;
					cards[i].shape = "♣";
				}
			}
			int dest, temp;
			for (int i = 0; i < 52; i++)
			{
				dest = random.Next(0, 52);
				temp = cards[dest].index;
				cards[dest].index = cards[i].index;
				cards[i].index = temp;
			}
			// card[52]짜리 배열을 수와 문양으로 변경
			for (int i = 0; i < 52; i++)
			{
				if (card[i] < 13)
				{

				}
			}
			int pick = 1;
			Console.WriteLine("~~~~ 월남뽕 ~~~~ 게임 ~~~~");
			int count = 0;  // 게임 판수
			while (true)
			{
				Console.WriteLine($"{count + 1}회차 게임을 시작합니다");
				Console.WriteLine("카드가 뽑혔습니다");
			}
		}
		static void Main(string[] args)
		{
			Homework();
		}
	}
}