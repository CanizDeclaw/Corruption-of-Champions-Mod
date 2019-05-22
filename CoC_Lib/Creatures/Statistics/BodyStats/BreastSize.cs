﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoC_Lib.Creatures.Statistics
{
    public enum BreastCup
    {
        Flat = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        DD = 5,
        DD_Big = 6,
        E = 7,
        E_Big = 8,
        EE = 9,
        EE_Big = 10,
        F = 11,
        F_Big = 12,
        FF = 13,
        FF_Big = 14,
        G = 15,
        G_Big = 16,
        GG = 17,
        GG_Big = 18,
        H = 19,
        H_Big = 20,
        HH = 21,
        HH_Big = 22,
        HHH = 23,
        I = 24,
        I_Big = 25,
        II = 26,
        II_Big = 27,
        J = 28,
        J_Big = 29,
        JJ = 30,
        JJ_Big = 31,
        K = 32,
        K_Big = 33,
        KK = 34,
        KK_Big = 35,
        L = 36,
        L_Big = 37,
        LL = 38,
        LL_Big = 39,
        M = 40,
        M_Big = 41,
        MM = 42,
        MM_Big = 43,
        MMM = 44,
        MMM_Large = 45,
        N = 46,
        N_Large = 47,
        NN = 48,
        NN_Large = 49,
        O = 50,
        O_Large = 51,
        OO = 52,
        OO_Large = 53,
        P = 54,
        P_Large = 55,
        PP = 56,
        PP_Large = 57,
        Q = 58,
        Q_Large = 59,
        QQ = 60,
        QQ_Large = 61,
        R = 62,
        R_Large = 63,
        RR = 64,
        RR_Large = 65,
        S = 66,
        S_Large = 67,
        SS = 68,
        SS_Large = 69,
        T = 70,
        T_Large = 71,
        TT = 72,
        TT_Large = 73,
        U = 74,
        U_Large = 75,
        UU = 76,
        UU_Large = 77,
        V = 78,
        V_Large = 79,
        VV = 80,
        VV_Large = 81,
        W = 82,
        W_Large = 83,
        WW = 84,
        WW_Large = 85,
        X = 86,
        X_Large = 87,
        XX = 88,
        XX_Large = 89,
        Y = 90,
        Y_Large = 91,
        YY = 92,
        YY_Large = 93,
        Z = 94,
        Z_Large = 95,
        ZZ = 96,
        ZZ_Large = 97,
        ZZZ = 98,
        ZZZ_Large = 99,
        Hyper_A = 100,
        Hyper_B = 101,
        Hyper_C = 102,
        Hyper_D = 103,
        Hyper_DD = 104,
        Hyper_DD_Big = 105,
        Hyper_E = 106,
        Hyper_E_Big = 107,
        Hyper_EE = 108,
        Hyper_EE_Big = 109,
        Hyper_F = 110,
        Hyper_F_Big = 111,
        Hyper_FF = 112,
        Hyper_FF_Big = 113,
        Hyper_G = 114,
        Hyper_G_Big = 115,
        Hyper_GG = 116,
        Hyper_GG_Big = 117,
        Hyper_H = 118,
        Hyper_H_Big = 119,
        Hyper_HH = 120,
        Hyper_HH_Big = 121,
        Hyper_HHH = 122,
        Hyper_I = 123,
        Hyper_I_Big = 124,
        Hyper_II = 125,
        Hyper_II_Big = 126,
        Hyper_J = 127,
        Hyper_J_Big = 128,
        Hyper_JJ = 129,
        Hyper_JJ_Big = 130,
        Hyper_K = 131,
        Hyper_K_Big = 132,
        Hyper_KK = 133,
        Hyper_KK_Big = 134,
        Hyper_L = 135,
        Hyper_L_Big = 136,
        Hyper_LL = 137,
        Hyper_LL_Big = 138,
        Hyper_M = 139,
        Hyper_M_Big = 140,
        Hyper_MM = 141,
        Hyper_MM_Big = 142,
        Hyper_MMM = 143,
        Hyper_MMM_Large = 144,
        Hyper_N = 145,
        Hyper_N_Large = 146,
        Hyper_NN = 147,
        Hyper_NN_Large = 148,
        Hyper_O = 149,
        Hyper_O_Large = 150,
        Hyper_OO = 151,
        Hyper_OO_Large = 152,
        Hyper_P = 153,
        Hyper_P_Large = 154,
        Hyper_PP = 155,
        Hyper_PP_Large = 156,
        Hyper_Q = 157,
        Hyper_Q_Large = 158,
        Hyper_QQ = 159,
        Hyper_QQ_Large = 160,
        Hyper_R = 161,
        Hyper_R_Large = 162,
        Hyper_RR = 163,
        Hyper_RR_Large = 164,
        Hyper_S = 165,
        Hyper_S_Large = 166,
        Hyper_SS = 167,
        Hyper_SS_Large = 168,
        Hyper_T = 169,
        Hyper_T_Large = 170,
        Hyper_TT = 171,
        Hyper_TT_Large = 172,
        Hyper_U = 173,
        Hyper_U_Large = 174,
        Hyper_UU = 175,
        Hyper_UU_Large = 176,
        Hyper_V = 177,
        Hyper_V_Large = 178,
        Hyper_VV = 179,
        Hyper_VV_Large = 180,
        Hyper_W = 181,
        Hyper_W_Large = 182,
        Hyper_WW = 183,
        Hyper_WW_Large = 184,
        Hyper_X = 185,
        Hyper_X_Large = 186,
        Hyper_XX = 187,
        Hyper_XX_Large = 188,
        Hyper_Y = 189,
        Hyper_Y_Large = 190,
        Hyper_YY = 191,
        Hyper_YY_Large = 192,
        Hyper_Z = 193,
        Hyper_Z_Large = 194,
        Hyper_ZZ = 195,
        Hyper_ZZ_Large = 196,
        Hyper_ZZZ = 197,
        Hyper_ZZZ_Large = 198,
        Jacques00 = 199,
    }

    public class BreastSize : BoundedIntegerStat
    {
        public override string Name => "Breast Size";
        public override string Description => "Breast size"; // TODO: Better description

        public virtual int Set(BreastCup cup) => Set((int)cup);
        // TODO: Surely there's a better way...
        public virtual BreastCup CupSize => (BreastCup)(int)Value;

        public BreastSize(Game game, Creature creature)
            :base(game, creature)
        {
            // TODO: Set everything up
            LowerBound = new IntLowerBound(value: 0, minimum: 0, maximum: 0);
            UpperBound = new IntUpperBound(value: 199, minimum: 199, maximum: 199);
            Set(BreastCup.Flat);
            // TODO: Breast size <-> cup conversions
        }
    }
}
