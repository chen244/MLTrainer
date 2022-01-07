﻿using Microsoft.ML.Data;
namespace Gisture
{
    internal class GistureData
    {
        [LoadColumn(0)]
        public float ThumbAngle { get; set; }

        [LoadColumn(1)]
        public float IndexAngle { get; set; }

        [LoadColumn(2)]
        public float MiddleAngle { get; set; }

        [LoadColumn(3)]
        public float RingAngle { get; set; }

        [LoadColumn(4)]
        public float PinkyAngle { get; set; }

        [LoadColumn(5)]
        public float ThumbIndex { get; set; }

        [LoadColumn(6)]
        public float IndexMiddle { get; set; }

        [LoadColumn(14)]
        public int Kind { get; set; }
    }
}