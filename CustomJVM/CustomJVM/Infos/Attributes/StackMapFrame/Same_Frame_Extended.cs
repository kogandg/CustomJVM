﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomJVM.Infos.Attributes.StackMapFrame
{
    public struct Same_Frame_Extended
    {
        public FrameTypes Frame_Type => FrameTypes.SAME_FRAME_EXTENDED; /* 251 */
        public ushort Offset_Delta;
    }
}