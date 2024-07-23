﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsDotNetFrameWork
{
    internal static class CheckOut
    {
        //169, 168, 166, 165, 163, 162, 159, (1) nem lehet kiszállni
        public static string Checkout(int point) //csak 170 alatt hívjuk meg
        {
            if (point <= 60) //2-60 tartomány, 40 alatt csak páros; nemkell továbbrasem else hogyha előtte return van de jóaz
            {
                if (point <= 60 && point >= 53) //53-60 közt
                {
                    return $"{point - 40} D20";
                }
                else if (point <= 52 && point >= 41) //41-52 közt
                {
                    return $"{point - 32} D16";
                }
                else if(point <= 40 && IsEven(point)) //40 alatt páros
                {
                    return $"D{point / 2}";
                }
                return checkouts[point];
            }
            else
            {
                return checkouts[point];
            }
        }

        private static bool IsEven(int point)
        {
            return (point % 2 == 0);
        }

        private static Dictionary<int, string> checkouts = new Dictionary<int, string>()
        {
            {170, "T20 T20 Bull"},
            {169, "://"},
            {168, "://"},
            {167, "T20 T19 Bull"},
            {166, "://"},
            {165, "://"},
            {164, "T20 T18 Bull"},
            {163, "://"},
            {162, "://"},
            {161, "T20 T17 Bull"},
            {160, "T20 T20 D20"},
            {159, "://"},
            {158, "T20 T20 D19"},
            {157, "T20 T19 D20"},
            {156, "T20 T20 D18"},
            {155, "T20 T19 D19"},
            {154, "T20 T18 D20"},
            {153, "T20 T19 D18"},
            {152, "T20 T20 D16"},
            {151, "T20 T17 D20"},
            {150, "T20 T18 D18"},
            {149, "T20 T19 D16"},
            {148, "T20 T16 D20"},
            {147, "T20 T17 D18"},
            {146, "T20 T18 D16"},
            {145, "T20 T15 D20"},
            {144, "T20 T20 D12"},
            {143, "T20 T17 D16"},
            {142, "T20 T14 D20"},
            {141, "T20 T19 D12"},
            {140, "T20 T16 D16"},
            {139, "T19 T14 D20"},
            {138, "T20 T18 D12"},
            {137, "T19 T16 D16"},
            {136, "T20 T20 D8"},
            {135, "T20 T17 D12"},
            {134, "T20 T14 D16"},
            {133, "T20 T19 D8"},
            {132, "T20 T16 D12"},
            {131, "T20 T13 D16"},
            {130, "T20 T20 D5"},
            {129, "T19 T16 D12"},
            {128, "T18 T14 D16"},
            {127, "T20 T17 D8"},
            {126, "T19 T19 D6"},
            {125, "25 T20 D20"},
            {124, "T20 T16 D8"},
            {123, "T19 T16 D9"},
            {122, "T18 T20 D4"},
            {121, "T17 T10 D20"},
            {120, "T20 20 D20"},
            {119, "T19 T10 D16"},
            {118, "T20 18 D20"},
            {117, "T20 17 D20"},
            {116, "T20 16 D20"},
            {115, "T20 15 D20"},
            {114, "T20 14 D20"},
            {113, "T20 13 D20"},
            {112, "T20 12 D20"},
            {111, "T20 19 D16"},
            {110, "T20 18 D16"},
            {109, "T19 20 D16"},
            {108, "T20 16 D16"},
            {107, "T19 18 D16"},
            {106, "T20 14 D16"},
            {105, "T19 16 D16"},
            {104, "T18 18 D16"},
            {103, "T20 3 D20"},
            {102, "T20 10 D16"},
            {101, "T20 1 D20"},
            {100, "T20 D20"},
            {99,  "T19 10 D16"},
            {98,  "T20 D19"},
            {97,  "T19 D20"},
            {96,  "T20 D18"},
            {95,  "T19 D19"},
            {94,  "T18 D20"},
            {93,  "T19 D18"},
            {92,  "T20 D16"},
            {91,  "T17 D20"},
            {90,  "T20 D15"},
            {89,  "T19 D16"},
            {88,  "T16 D20"},
            {87,  "T17 D18"},
            {86,  "T18 D16"},
            {85,  "T15 D20"},
            {84,  "T20 D12"},
            {83,  "T17 D16"},
            {82,  "T14 D20"},
            {81,  "T19 D12"},
            {80,  "T20 D10"},
            {79,  "T19 D11"},
            {78,  "T18 D12"},
            {77,  "T19 D10"},
            {76,  "T20 D8"},
            {75,  "T17 D12"},
            {74,  "T14 D16"},
            {73,  "T19 D8"},
            {72,  "T16 D12"},
            {71,  "T13 D16"},
            {70,  "T10 D20"},
            {69,  "T15 D12"},
            {68,  "T20 D4"},
            {67,  "T17 D8"},
            {66,  "T10 D18"},
            {65,  "T19 D4"},
            {64,  "T16 D8"},
            {63,  "T13 D12"},
            {62,  "T10 D16"},
            {61,  "T15 D8"},
            {39,  "7 D16"},
            {37,  "5 D16"},
            {35,  "3 D16"},
            {33,  "17 D8"},
            {31,  "15 D8"},
            {29,  "13 D8"},
            {27,  "19 D4"},
            {25,  "9 D8"},
            {23,  "7 D8"},
            {21,  "13 D4"},
            {19,  "11 D4"},
            {17,  "9 D4"},
            {15,  "7 D4"},
            {13,  "5 D4"},
            {11,  "3 D4"},
            {9,   "1 D4"},
            {7,   "3 D2"},
            {5,   "1 D2"},
            {3,   "1 D1"},
            {1,   "szarul számoltad lol"}
        };
    }
}
