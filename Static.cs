using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241007
{
	/*
	[ 정적 변수(static Variable) ]
	-  인스턴스가 아닌 클래스 자체에 포함.
	-  하나의 정적필드는 모든 인스턴스가 동일한 값을 공유

	[ 정적 함수(static Function) ]
	-  인스턴스가 없어도 호출
	- 인스턴스 멤버에는 접근 X
	- 객체의 인스턴스와 무관하게 클래스 자체에 속하는 메서드

	[ 정적 클래스(static Class) ]
	- 인스턴스를 생성할수 없음.
	- 멤버가 정적이어야 함.
	- 상속불가
	*/

	//정적 클래스
	static class Math
	{
		//int a;              //정적 클래스에는 인스턴스 멤버를 선언 x
		//void print() { }    //마찬가지로 메서드를 선언 x

		public static int b;
		public static int Sum(int a, int b)
		{
			return a + b;
		}
	}
	class Math1
	{
		public static int b;
		public Math1() { }
		//정적 메서드
		public static int Sum(int a, int b)
		{
			return a + b;
		}
	}
	internal class Static
	{
		static void Main(string[] args)
		{
			int sum = Math1.Sum(1, 2);
			//Math m = new Math();
		}
	}
}