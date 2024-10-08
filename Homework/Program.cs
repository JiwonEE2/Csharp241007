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
            for(int i = 0; i < scores.Length; i++)
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
            string sentence = Console.ReadLine();
            // 띄어쓰기로 쪼개기
            string[] words = sentence.Split(' ');
            string[] newWords= new string[words.Length];
            for(int i = 0;i < words.Length;i++)
            {
                for(int j= 0;j<
                char newWords[i] = (char)words[i];
            }
        }
        static void Main(string[] args)
        {
            Homework1();
        }
    }
}