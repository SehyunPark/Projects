using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public const int Yes = 1;
public const int No = 0;

namespace School_Project
{
    public class Student
    {
        int number = xxxxx; // 팀원간의 플레이 시나리오 가능할 수도
    }
    
    abstract class Building
    {
        public abstract int Succeed_or_Not
        {
            get;
            set;
        }
    }

    class Saebit : Building
    {
        public int number;
        public int result
        // 새빛에서의 여러 기능들 나열
        // 아래 예시
        private int WorkA()
        {
          // WorkA로 정의한 새빛관 내에서의 미션 수행 함수
        }

        private int WorkB()
        {
            // WorkB로 정의한 새빛관 내에서의 미션 수행 함수
        }
        public Saebit(int k)
        {
            number = k;
        }

        public override int Succeed_or_Not {
            get { return result; } 
            // set { result = function(number)......;
            // set 구문에 result에 대입시키기 위한 여러 function의 결과값을 집어넣음
        }
    }

    class Chambit : Building
    {

    }

    class Bima : Building
    {

    }

    class Welfare : Building
    {

    }

    class Dorm : Building
    {

    }

    class Hanwol : Building
    {

    }

    class Nuri : Building
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 학생 a, b, c 등등 만들기 (객체 인스턴스 생성)
            // 학생별 다녀갈 빌딩 정하기 (임의로 -> 임의 순서이기에 rand() 사용
            Random r = new Random();
            int number = r.Next(1, 50);
            if (number % 6 == 0)
            {
                // 새빛관 가세요
            }

           else if (number % 6 == 1)
            {
                // 참빛관 가세요
            }
            // 이후 빌딩들 주루룩 나열


            // 등등 Random()의 인스터스 객체의 Next() 결과로 갈 빌딩 파악
            // 이후 각 빌딩 별 기능 사용하여 미션 수행 여부 조사 (성공 시 1, 실패 시 0)

        }
    }
}
