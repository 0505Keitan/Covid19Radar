﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Covid19Radar.Api.Common
{
    public class PartitionKeyRotation
    {
        private readonly KeyInformation[] Keys;
        private readonly int Max;
        private int Current = -1;
        public PartitionKeyRotation(string[] keys)
        {
            Keys = keys.Select(_ => new KeyInformation(_)).ToArray();
            Max = keys.Length;
            Current = RandomNumberGenerator.GetInt32(0, Max - 1);
        }

        public KeyInformation Next()
        {
            var nextValue = Interlocked.Increment(ref Current);
            var nextKey = Keys[nextValue % Max];
            if (nextValue >= Max)
            {
                Interlocked.CompareExchange(ref Current, nextValue % Max, nextValue);
            }
            return nextKey;
        }

        public class KeyInformation
        {
            private string _Self;
            public KeyInformation(string key)
            {
                Key = key;
            }
            public string Key { get; }
            public string Self { get => _Self; }
            public void SetSelf(string self)
            {
                Interlocked.CompareExchange(ref _Self, self, null);
            }
        }
    }
}
