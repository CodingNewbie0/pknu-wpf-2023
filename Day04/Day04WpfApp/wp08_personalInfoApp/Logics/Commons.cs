﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wp08_personalInfoApp.Logics
{
    internal class Commons
    {
        public static bool IsValidEmail(string email)
        {
            // 이메일 형식에 맞게 입력하도록 체크(검증체크)
            return true;
        }

        public static int GetAge(DateTime value)
        {
            // 입력된 날짜로 나이를 계산
            return 30;
        }

        public static string GetZodiac(DateTime value)
        {
            // 입력된 생일로 12지신을 리턴
            return "용띠";
        }
    }
}
