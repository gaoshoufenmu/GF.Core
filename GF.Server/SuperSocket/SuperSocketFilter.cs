using System;
using System.Collections.Generic;
using System.Text;
using SuperSocket.ProtoBase;

namespace GF.Server
{
    public class SuperSocketReceiveFilter : FixedHeaderReceiveFilter<BufferedPackageInfo<ushort>>
    {
        //---------------------------------------------------------------------
        sealed class BufferState : BufferBaseState { }

        //---------------------------------------------------------------------
        public SuperSocketReceiveFilter()
            : base(sizeof(ushort))
        {
        }

        //---------------------------------------------------------------------
        protected override int GetBodyLengthFromHeader(IList<ArraySegment<byte>> package_data, int length)
        {
            using (var reader = this.GetBufferReader<BufferedPackageInfo<ushort>>(package_data))
            {
                return reader.ReadUInt16(true);
            }
        }

        //---------------------------------------------------------------------
        public override BufferedPackageInfo<ushort> ResolvePackage(IList<ArraySegment<byte>> package_data)
        {
            using (var reader = this.GetBufferReader<BufferedPackageInfo<ushort>>(package_data))
            {
                ushort body_len = reader.ReadUInt16(true);

                //var bl = reader.Take(body_len);

                byte[] data = new byte[body_len];
                reader.ReadBytes(data, 0, body_len);
                BufferList buf = new BufferList();
                buf.Add(new ArraySegment<byte>(data), new BufferState());
                return new BufferedPackageInfo<ushort>(body_len, buf);

                //return mPackage;
                //return new BufferedPackageInfo<ushort>(body_len, package_data);
            }
        }
    }
}
