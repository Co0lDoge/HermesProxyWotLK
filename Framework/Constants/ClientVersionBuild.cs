﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesProxy.Enums
{
    public enum ClientVersionBuild
    {
        // ReSharper disable InconsistentNaming
        Zero = 0,

        V1_9_4_5086 = 5086,
        V1_12_1_5875 = 5875,
        V1_12_2_6005 = 6005,
        V1_12_3_6141 = 6141,

        V2_0_1_6180 = 6180,
        V2_0_3_6299 = 6299,
        V2_0_6_6337 = 6337,
        V2_1_0_6692 = 6692,
        V2_1_1_6739 = 6739,
        V2_1_2_6803 = 6803,
        V2_1_3_6898 = 6898,
        V2_2_0_7272 = 7272,
        V2_2_2_7318 = 7318,
        V2_2_3_7359 = 7359,
        V2_3_0_7561 = 7561,
        V2_3_2_7741 = 7741,
        V2_3_3_7799 = 7799,
        V2_4_0_8089 = 8089,
        V2_4_1_8125 = 8125,
        V2_4_2_8209 = 8209,
        V2_4_3_8606 = 8606,

        V3_0_2_9056 = 9056,
        V3_0_3_9183 = 9183,
        V3_0_8_9464 = 9464,
        V3_0_8a_9506 = 9506,
        V3_0_9_9551 = 9551,
        V3_1_0_9767 = 9767,
        V3_1_1_9806 = 9806,
        V3_1_1a_9835 = 9835,
        V3_1_2_9901 = 9901,
        V3_1_3_9947 = 9947,
        V3_2_0_10192 = 10192,
        V3_2_0a_10314 = 10314,
        V3_2_2_10482 = 10482,
        V3_2_2a_10505 = 10505,
        V3_3_0_10958 = 10958,
        V3_3_0a_11159 = 11159,
        V3_3_2_11403 = 11403,
        V3_3_3_11685 = 11685,
        V3_3_3a_11723 = 11723,
        V3_3_5_12213 = 12213,
        V3_3_5_12340 = 12340,

        V4_0_1_13164 = 13164,
        V4_0_1a_13205 = 13205,
        V4_0_3_13329 = 13329,
        V4_0_6_13596 = 13596,
        V4_0_6a_13623 = 13623,
        V4_1_0_13914 = 13914,
        V4_1_0a_14007 = 14007,
        V4_2_0_14333 = 14333,
        V4_2_0a_14480 = 14480,
        V4_2_2_14545 = 14545,
        V4_3_0_15005 = 15005,
        V4_3_0a_15050 = 15050,
        V4_3_2_15211 = 15211,
        V4_3_3_15354 = 15354,
        V4_3_4_15595 = 15595,
        V5_0_4_16016 = 16016,
        V5_0_5_16048 = 16048,
        V5_0_5a_16057 = 16057,
        V5_0_5b_16135 = 16135,
        V5_1_0_16309 = 16309,
        V5_1_0a_16357 = 16357,
        V5_2_0_16650 = 16650,
        V5_2_0_16669 = 16669,
        V5_2_0_16683 = 16683,
        V5_2_0_16685 = 16685,
        V5_2_0_16701 = 16701,
        V5_2_0_16709 = 16709,
        V5_2_0_16716 = 16716,
        V5_2_0_16733 = 16733,
        V5_2_0_16769 = 16769,
        V5_2_0_16826 = 16826,
        V5_3_0_16981 = 16981,
        V5_3_0_16983 = 16983,
        V5_3_0_16992 = 16992,
        V5_3_0_17055 = 17055,
        V5_3_0_17116 = 17116,
        V5_3_0_17128 = 17128,
        V5_4_0_17359 = 17359,
        V5_4_0_17371 = 17371,
        V5_4_0_17399 = 17399,
        V5_4_1_17538 = 17538,
        V5_4_2_17658 = 17658,
        V5_4_2_17688 = 17688,
        V5_4_7_17898 = 17898,
        V5_4_7_17930 = 17930,
        V5_4_7_17956 = 17956,
        V5_4_7_18019 = 18019,
        V5_4_8_18291 = 18291,
        V5_4_8_18414 = 18414,
        V6_0_2_19033 = 19033,
        V6_0_2_19034 = 19034,
        V6_0_3_19103 = 19103,
        V6_0_3_19116 = 19116,
        V6_0_3_19243 = 19243,
        V6_0_3_19342 = 19342,
        V6_1_0_19678 = 19678,
        V6_1_0_19702 = 19702,
        V6_1_2_19802 = 19802,
        V6_1_2_19831 = 19831,
        V6_1_2_19865 = 19865,
        V6_2_0_20173 = 20173,
        V6_2_0_20182 = 20182,
        V6_2_0_20201 = 20201,
        V6_2_0_20216 = 20216,
        V6_2_0_20253 = 20253,
        V6_2_0_20338 = 20338,
        V6_2_2_20444 = 20444,
        V6_2_2a_20490 = 20490,
        V6_2_2a_20574 = 20574,
        V6_2_3_20726 = 20726,
        V6_2_3_20779 = 20779,
        V6_2_3_20886 = 20886,
        V6_2_4_21315 = 21315,
        V6_2_4_21336 = 21336,
        V6_2_4_21343 = 21343,
        V6_2_4_21345 = 21345,
        V6_2_4_21348 = 21348,
        V6_2_4_21355 = 21355,
        V6_2_4_21463 = 21463,
        V6_2_4_21676 = 21676,
        V6_2_4_21742 = 21742,
        V7_0_3_22248 = 22248,
        V7_0_3_22267 = 22267,
        V7_0_3_22277 = 22277,
        V7_0_3_22280 = 22280,
        V7_0_3_22289 = 22289,
        V7_0_3_22293 = 22293,
        V7_0_3_22345 = 22345,
        V7_0_3_22396 = 22396,
        V7_0_3_22410 = 22410,
        V7_0_3_22423 = 22423,
        V7_0_3_22445 = 22445,
        V7_0_3_22498 = 22498,
        V7_0_3_22522 = 22522,
        V7_0_3_22566 = 22566,
        V7_0_3_22594 = 22594,
        V7_0_3_22624 = 22624,
        V7_0_3_22747 = 22747,
        V7_0_3_22810 = 22810,
        V7_1_0_22900 = 22900,
        V7_1_0_22908 = 22908,
        V7_1_0_22950 = 22950,
        V7_1_0_22989 = 22989,
        V7_1_0_22995 = 22995,
        V7_1_0_22996 = 22996,
        V7_1_0_23171 = 23171,
        V7_1_0_23222 = 23222,
        V7_1_5_23360 = 23360,
        V7_1_5_23420 = 23420,
        V7_2_0_23706 = 23706,
        V7_2_0_23826 = 23826,
        V7_2_0_23835 = 23835,
        V7_2_0_23836 = 23836,
        V7_2_0_23846 = 23846,
        V7_2_0_23852 = 23852,
        V7_2_0_23857 = 23857,
        V7_2_0_23877 = 23877,
        V7_2_0_23911 = 23911,
        V7_2_0_23937 = 23937,
        V7_2_0_24015 = 24015,
        V7_2_5_24330 = 24330,
        V7_2_5_24367 = 24367,
        V7_2_5_24414 = 24414,
        V7_2_5_24415 = 24415,
        V7_2_5_24430 = 24430,
        V7_2_5_24461 = 24461,
        V7_2_5_24742 = 24742,
        V7_3_0_24920 = 24920,
        V7_3_0_24931 = 24931,
        V7_3_0_24956 = 24956,
        V7_3_0_24970 = 24970,
        V7_3_0_24974 = 24974,
        V7_3_0_25021 = 25021,
        V7_3_0_25195 = 25195,
        V7_3_2_25383 = 25383,
        V7_3_2_25442 = 25442,
        V7_3_2_25455 = 25455,
        V7_3_2_25477 = 25477,
        V7_3_2_25480 = 25480,
        V7_3_2_25497 = 25497,
        V7_3_2_25549 = 25549,

        V7_3_5_25848 = 25848,
        V7_3_5_25860 = 25860,
        V7_3_5_25864 = 25864,
        V7_3_5_25875 = 25875,
        V7_3_5_25881 = 25881,
        V7_3_5_25901 = 25901,
        V7_3_5_25928 = 25928,
        V7_3_5_25937 = 25937,
        V7_3_5_25944 = 25944,
        V7_3_5_25946 = 25946,
        V7_3_5_25950 = 25950,
        V7_3_5_25961 = 25961,
        V7_3_5_25996 = 25996,
        V7_3_5_26124 = 26124,
        V7_3_5_26365 = 26365,
        V7_3_5_26654 = 26654,
        V7_3_5_26755 = 26755,
        V7_3_5_26822 = 26822,
        V7_3_5_26899 = 26899,
        V7_3_5_26972 = 26972,

        V8_0_1_27101 = 27101,
        V8_0_1_27144 = 27144,
        V8_0_1_27165 = 27165,
        V8_0_1_27178 = 27178,
        V8_0_1_27219 = 27219,
        V8_0_1_27291 = 27291,
        V8_0_1_27326 = 27326,
        V8_0_1_27355 = 27355,
        V8_0_1_27356 = 27356,
        V8_0_1_27366 = 27366,
        V8_0_1_27377 = 27377,
        V8_0_1_27404 = 27404,
        V8_0_1_27481 = 27481,
        V8_0_1_27547 = 27547,
        V8_0_1_27602 = 27602,
        V8_0_1_27791 = 27791,
        V8_0_1_27843 = 27843,
        V8_0_1_27980 = 27980,
        V8_0_1_28153 = 28153,

        V8_1_0_28724 = 28724,
        V8_1_0_28768 = 28768,
        V8_1_0_28807 = 28807,
        V8_1_0_28822 = 28822,
        V8_1_0_28833 = 28833,
        V8_1_0_29088 = 29088,
        V8_1_0_29139 = 29139,
        V8_1_0_29235 = 29235,
        V8_1_0_29285 = 29285,
        V8_1_0_29297 = 29297,
        V8_1_0_29482 = 29482,
        V8_1_0_29600 = 29600,
        V8_1_0_29621 = 29621,

        V8_1_5_29683 = 29683,
        V8_1_5_29701 = 29701,
        V8_1_5_29704 = 29704,
        V8_1_5_29705 = 29705,
        V8_1_5_29718 = 29718,
        V8_1_5_29732 = 29732,
        V8_1_5_29737 = 29737,
        V8_1_5_29814 = 29814,
        V8_1_5_29869 = 29869,
        V8_1_5_29896 = 29896,
        V8_1_5_29981 = 29981,
        V8_1_5_30477 = 30477,
        V8_1_5_30706 = 30706,

        V8_2_0_30898 = 30898,
        V8_2_0_30918 = 30918,
        V8_2_0_30920 = 30920,
        V8_2_0_30948 = 30948,
        V8_2_0_30993 = 30993,
        V8_2_0_31229 = 31229,
        V8_2_0_31429 = 31429,
        V8_2_0_31478 = 31478,

        V8_2_5_31921 = 31921,
        V8_2_5_31958 = 31958,
        V8_2_5_31960 = 31960,
        V8_2_5_31961 = 31961,
        V8_2_5_31984 = 31984,
        V8_2_5_32028 = 32028,
        V8_2_5_32144 = 32144,
        V8_2_5_32185 = 32185,
        V8_2_5_32265 = 32265,
        V8_2_5_32294 = 32294,
        V8_2_5_32305 = 32305,
        V8_2_5_32494 = 32494,
        V8_2_5_32580 = 32580,
        V8_2_5_32638 = 32638,
        V8_2_5_32722 = 32722,
        V8_2_5_32750 = 32750,
        V8_2_5_32978 = 32978,

        V8_3_0_33062 = 33062,
        V8_3_0_33073 = 33073,
        V8_3_0_33084 = 33084,
        V8_3_0_33095 = 33095,
        V8_3_0_33115 = 33115,
        V8_3_0_33169 = 33169,
        V8_3_0_33237 = 33237,
        V8_3_0_33369 = 33369,
        V8_3_0_33528 = 33528,
        V8_3_0_33724 = 33724,
        V8_3_0_33775 = 33775,
        V8_3_0_33941 = 33941,
        V8_3_0_34220 = 34220,
        V8_3_0_34601 = 34601,
        V8_3_0_34769 = 34769,
        V8_3_0_34963 = 34963,

        V8_3_7_35249 = 35249,
        V8_3_7_35284 = 35284,
        V8_3_7_35435 = 35435,
        V8_3_7_35662 = 35662,

        V9_0_1_36216 = 36216,
        V9_0_1_36228 = 36228,
        V9_0_1_36230 = 36230,
        V9_0_1_36247 = 36247,
        V9_0_1_36272 = 36272,
        V9_0_1_36322 = 36322,
        V9_0_1_36372 = 36372,
        V9_0_1_36492 = 36492,
        V9_0_1_36577 = 36577,

        V9_0_2_36639 = 36639,
        V9_0_2_36665 = 36665,
        V9_0_2_36671 = 36671,
        V9_0_2_36710 = 36710,
        V9_0_2_36734 = 36734,
        V9_0_2_36751 = 36751,
        V9_0_2_36753 = 36753,
        V9_0_2_36839 = 36839,
        V9_0_2_36949 = 36949,
        V9_0_2_37106 = 37106,
        V9_0_2_37142 = 37142,
        V9_0_2_37176 = 37176,
        V9_0_2_37474 = 37474,

        V9_0_5_37503 = 37503, // PTR
        V9_0_5_37862 = 37862,
        V9_0_5_37864 = 37864,
        V9_0_5_37893 = 37893,
        V9_0_5_37899 = 37899,
        V9_0_5_37988 = 37988,
        V9_0_5_38134 = 38134,
        V9_0_5_38556 = 38556,

        V9_1_0_39185 = 39185,
        V9_1_0_39226 = 39226,
        V9_1_0_39229 = 39229,
        V9_1_0_39262 = 39262,
        V9_1_0_39282 = 39282,
        V9_1_0_39289 = 39289,
        V9_1_0_39291 = 39291,
        V9_1_0_39318 = 39318,
        V9_1_0_39335 = 39335,
        V9_1_0_39427 = 39427,
        V9_1_0_39497 = 39497,
        V9_1_0_39498 = 39498,
        V9_1_0_39584 = 39584,
        V9_1_0_39617 = 39617,
        V9_1_0_39653 = 39653,
        V9_1_0_39804 = 39804,
        V9_1_0_40000 = 40000,
        V9_1_0_40120 = 40120,
        V9_1_0_40443 = 40443,
        V9_1_0_40593 = 40593,
        V9_1_0_40725 = 40725,

        V9_1_5_40772 = 40772,
        V9_1_5_40871 = 40871,
        V9_1_5_40906 = 40906,
        V9_1_5_40944 = 40944,
        V9_1_5_40966 = 40966,
        V9_1_5_41031 = 41031,
        V9_1_5_41079 = 41079,
        V9_1_5_41288 = 41288,
        V9_1_5_41323 = 41323,
        V9_1_5_41359 = 41359,
        V9_1_5_41488 = 41488,
        V9_1_5_41793 = 41793,
        V9_1_5_42010 = 42010,

        // Classic
        V1_13_2_31446 = 31446, // name reservation
        V1_13_2_31650 = 31650, // launch
        V1_13_2_31687 = 31687,
        V1_13_2_31727 = 31727,
        V1_13_2_31830 = 31830,
        V1_13_2_31882 = 31882,
        V1_13_2_32089 = 32089,
        V1_13_2_32421 = 32421,
        V1_13_2_32600 = 32600,

        V1_13_3_32790 = 32790,
        V1_13_3_32836 = 32836,
        V1_13_3_32887 = 32887,
        V1_13_3_33155 = 33155,
        V1_13_3_33302 = 33302, // bwl release
        V1_13_3_33485 = 33485, // ptr
        V1_13_3_33526 = 33526,

        V1_13_4_33491 = 33491, // ptr
        V1_13_4_33598 = 33598, // both live and ptr
        V1_13_4_33645 = 33645, // both live and ptr
        V1_13_4_33728 = 33728, // both live and ptr
        V1_13_4_33920 = 33920, // both live and ptr
        v1_13_4_34219 = 34219,
        v1_13_4_34266 = 34266,
        v1_13_4_34600 = 34600,
        v1_13_4_34835 = 34835,

        v1_13_5_34713 = 34713, // ptr
        v1_13_5_34911 = 34911, // ptr
        v1_13_5_35000 = 35000, // both live and ptr
        v1_13_5_35186 = 35186,
        v1_13_5_35395 = 35395,
        v1_13_5_35663 = 35663,
        v1_13_5_35705 = 35705,
        v1_13_5_35753 = 35753,
        v1_13_5_36035 = 36035,
        v1_13_5_36307 = 36307,
        v1_13_5_36325 = 36325,

        v1_13_6_36149 = 36149, // ptr
        v1_13_6_36231 = 36231, // ptr
        v1_13_6_36310 = 36310, // ptr
        V1_13_6_36324 = 36324, // ptr
        V1_13_6_36497 = 36497, // ptr
        V1_13_6_36524 = 36524, // ptr
        V1_13_6_36611 = 36611, // ptr
        V1_13_6_36670 = 36670, // ptr
        V1_13_6_36714 = 36714, // both live and ptr
        V1_13_6_36935 = 36935, // both live and ptr
        V1_13_6_37497 = 37497,

        // Some-Changes Policy Begins
        V1_13_7_37279 = 37279, // ptr
        V1_13_7_37429 = 37429, // ptr
        V1_13_7_37892 = 37892, // ptr
        V1_13_7_38178 = 38178, // ptr
        V1_13_7_38296 = 38296, // ptr
        V1_13_7_38363 = 38363, // both live and ptr
        V1_13_7_38386 = 38386,
        V1_13_7_38475 = 38475,
        V1_13_7_38631 = 38631, // last version before tbc pre patch
        V1_13_7_38704 = 38704,
        V1_13_7_39605 = 39605, // both live and ptr
        V1_13_7_39692 = 39692,

        // Classic-Era rebased upon TBC client
        V1_14_0_39802 = 39802, // ptr
        V1_14_0_39958 = 39958, // ptr
        V1_14_0_40140 = 40140, // ptr
        V1_14_0_40179 = 40179, // ptr
        V1_14_0_40237 = 40237, // ptr
        V1_14_0_40347 = 40347, // both live and ptr
        V1_14_0_40441 = 40441, // both live and ptr
        V1_14_0_40618 = 40618,

        // Classic SoM
        V1_14_1_40487 = 40487, // ptr
        V1_14_1_40594 = 40594, // ptr
        V1_14_1_40666 = 40666, // ptr
        V1_14_1_40688 = 40688, // ptr
        V1_14_1_40800 = 40800, // ptr
        V1_14_1_40818 = 40818, // ptr
        V1_14_1_40926 = 40926, // ptr
        V1_14_1_40962 = 40962, // both live and ptr
        V1_14_1_41009 = 41009, // ptr
        V1_14_1_41030 = 41030, // both live and ptr
        V1_14_1_41077 = 41077, // both live and ptr
        V1_14_1_41137 = 41137, // both live and ptr
        V1_14_1_41243 = 41243, // both live and ptr
        V1_14_1_41511 = 41511, // both live and ptr
        V1_14_1_41794 = 41794, // both live and ptr
        V1_14_1_42032 = 42032, // live

        V1_14_2_41858 = 41858, // ptr
        V1_14_2_41959 = 41959, // ptr
        V1_14_2_42065 = 42065, // ptr
        V1_14_2_42082 = 42082, // ptr
        V1_14_2_42214 = 42214, // both live and ptr
        V1_14_2_42597 = 42597, // both live and ptr

        // TBC Classic
        V2_5_1_38598 = 38598, // ptr
        V2_5_1_38644 = 38644,
        V2_5_1_38707 = 38707, // pre patch
        V2_5_1_38741 = 38741,
        V2_5_1_38757 = 38757,
        V2_5_1_38835 = 38835, // launch
        V2_5_1_38892 = 38892,
        V2_5_1_38921 = 38921,
        V2_5_1_38988 = 38988,
        V2_5_1_39170 = 39170,
        V2_5_1_39475 = 39475,
        V2_5_1_39603 = 39603,
        V2_5_1_39640 = 39640,

        V2_5_2_39570 = 39570, // ptr
        V2_5_2_39618 = 39618, // ptr
        V2_5_2_39926 = 39926, // ptr
        V2_5_2_40011 = 40011, // both live and ptr
        V2_5_2_40045 = 40045, // live
        V2_5_2_40203 = 40203, // both live and ptr
        V2_5_2_40260 = 40260, // both live and ptr
        V2_5_2_40422 = 40422, // both live and ptr
        V2_5_2_40488 = 40488, // both live and ptr
        V2_5_2_40617 = 40617, // both live and ptr
        V2_5_2_40892 = 40892, // both live and ptr
        V2_5_2_41446 = 41446, // live
        V2_5_2_41510 = 41510, // live

        V2_5_3_41402 = 41402, // ptr
        V2_5_3_41531 = 41531, // ptr
        V2_5_3_41750 = 41750, // ptr
        V2_5_3_41812 = 41812, // both live and ptr
        V2_5_3_42083 = 42083, // both live and ptr
        V2_5_3_42328 = 42328, // both live and ptr
        V2_5_3_42598 = 42598, // live

        V3_4_3_54261 = 54261,

        // Battle.net - should probably not mix this but oh well
        BattleNetV37165 = 37165,

        // ReSharper restore InconsistentNaming
    }
}
