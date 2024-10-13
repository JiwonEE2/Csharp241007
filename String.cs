using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;   // Stopwatch 사용을 위함

namespace Csharp241007
{
	internal class String
	{
		static void Main(string[] args)
		{
			/*
			[ String ]
			- 문자들의 집합으로 표현
			- 내부적으로 문자 배열을 통해 구현
			*/

			string str = "abcde";
			Console.WriteLine(str);
			Console.WriteLine(str[0]);

			//str[1] = 'd';		// error : 문자열의 배열 접근은 ReadOnly

			/*
			[ String의 불변성 ]
			- string은 특징 상 다른 기본 자료형과 다르게 크기가 정해져 있지 않은 기본 자료형이다.
			- 이유는 string은 char의 집합이므로 char의 갯수에 따라 크기가 유동적
			- 따라서 string은 런타임 당시에 크기가 결정. 그 크기는 일정하지 않음
			- 이에 string은 다른 기본 자료형과 다르게 구조체가 아닌 클래스로 구현(런타임 시 크기를 정할 수 있는 메모리는 힙 영역을 사용)
			- 단, 기본 자료형과 같이 값형식을 구현하기 위해 string 클래스의 처리는 값형식처럼 동작하도록 구현
			- 이를 구현하기 위해 string 간의 대입이 있을 경우 참조에 의한 주소값 복사가 아닌 깊은 복사를 진행
			- 결과적으로 데이터 자체를 복사하는 값형식으로 사용하지만 힙 영역을 사용하기 때문에 string이 설정되면 변경할 수 없도록 하는 불변성을 가지게 됨
			*/
			string str1 = "abcde";  // 힙 영역에 abcde 문자열을 저장하며 이를 str1이 참조
			str1 = "abc";           // 새로운 힙 영역에 abc 문자열을 저장하여 이를 str1이 참조
			str1 = str1 + "123";    // 새로운 힙 영역에 abc123 문자열을 저장하며 이를 str1이 참조

			string str2 = str1;     // 클래스지만 string은 값형식처럼 사용되어야 하기 때문에 힙 영역에 abc123 문자열을 복사하여 str2가 참조하도록 함

			/*
			[ 메모리 파편화 ]
			- string이 불변성 특징을 가지기 때문에 새로운 데이터를 string에 할당할 때마다 기존 데이터 버려짐
			- 버려지는 힙 영역의 데이터는 가비지 컬렉터의 대상
			*/
			string str3 = "abc" + 123 + "def" + 456;
			// abc123def456
			// + 연산은 지양하는 게 좋다. 가비지가 된다.
			// 문자열 결합 시 StringBuilder 사용이 훨씬 효율적

			const int iter = 100000;
			Stopwatch stringStop = Stopwatch.StartNew();
			string res = "";
			for (int i = 0; i < 1000; i++)
			{
				res += "a";     // 성능 저하..
			}
			stringStop.Stop();
			Console.WriteLine($"스트링 : {stringStop.ElapsedMilliseconds}");

			Stopwatch StringBuilderStop = Stopwatch.StartNew();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < iter; i++)
			{
				stringBuilder.Append("a");
			}
			StringBuilderStop.Stop();
			Console.WriteLine($"스트링빌더 : {StringBuilderStop.ElapsedMilliseconds}");

			/*
			[ String 메서드 ]
			- indexOf : 현재 문자열 내에서 찾고자하는 지정된 문자 또는 문자열을 찾는다.
			- LastIndexOf : 위와 동일하나 뒤에서부터
			- StartWith : 현재 문자열이 지정된 문자열로 시작하는가?
			- EndWith : 현재 문자열이 지정된 문자열로 끝나는가?
			- Contains : 현재 문자열이 지정된 문자열을 포함하는가?
			- Replace : 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바꿔 새로운 문자열을 반환
			- Length : 길이
			- Equals : 같은가?
			- SubString : 지정된 인덱스로부터 문자 추출
			- Trim : 공백 제거
			- Split : 문자열 분할
			*/

			string str5 = "Kyungil Game Academy";
			// 대소문자 구분. 실패하면(없으면) -1을 리턴
			Console.WriteLine("Game이 시작되는 위치는 어디인가? : {0}", str5.IndexOf("ame"));
			Console.WriteLine("Kyungil로 시작하는가? : {0}", str5.StartsWith("Kyungil"));       // true
			Console.WriteLine("Academy로 시작하는가? : {0}", str5.StartsWith("Academy"));       // false
			Console.WriteLine("Academy를 test로 변경 : {0}", str5.Replace("Academy", "test"));

			string original = "Hello, World";
			string substr = original.Substring(7, 5);       // 7번째 인덱스로부터 5개 문자 추출
			Console.WriteLine(substr);                      // world

			string Space = "    Hello,      World     ";
			string SpaceTrim = Space.Trim();
			Console.WriteLine(SpaceTrim);

			string sentence = "공백으로 문장을 잘게 잘 게 쪼개볼 까";
			string[] words = sentence.Split(' ');
			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}