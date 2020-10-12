﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DTXMania2.演奏
{
    /// <summary>
    ///     AutoPlay の指定単位。
    ///     AotoPlay が指定可能なチップは、この種別のいずれかに属する。
    /// </summary>
    enum AutoPlay種別
    {
        Unknown,
        LeftCrash,
        HiHat,
        Foot,   // 左ペダル
        Snare,
        Bass,
        Tom1,
        Tom2,
        Tom3,
        RightCrash,
    }
}
