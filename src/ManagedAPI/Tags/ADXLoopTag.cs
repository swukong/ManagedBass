using ManagedBass.Dynamics;
using System;
using System.Runtime.InteropServices;

namespace ManagedBass
{	
	[StructLayout(LayoutKind.Sequential)]
	public struct ADXLoopTag
	{
		/// <summary>
		/// Is looping is enabled.
		/// </summary>
		public bool LoopEnabled;

		/// <summary>
		/// The sample start position.
		/// </summary>
		public long SampleStart;

		/// <summary>
		/// The byte start position.
		/// </summary>
		public long ByteStart;

		/// <summary>
		/// The sample end position.
		/// </summary>
		public long SampleEnd;

		/// <summary>
		/// The byte end position.
		/// </summary>
		public long ByteEnd;

        public static ADXLoopTag Read(int Channel)
        {
            return (ADXLoopTag)Marshal.PtrToStructure(Bass.ChannelGetTags(Channel, TagType.AdxLoop), typeof(ADXLoopTag));
        }
	}
}