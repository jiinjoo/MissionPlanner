


using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using uint64_t = System.UInt64;

using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;
using int64_t = System.Int64;

using float32 = System.Single;

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DroneCAN
{

    public partial class DroneCAN {
        static void encode_uavcan_protocol_AccessCommandShell_res(uavcan_protocol_AccessCommandShell_res msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx) {
            uint8_t[] buffer = new uint8_t[8];
            _encode_uavcan_protocol_AccessCommandShell_res(buffer, msg, chunk_cb, ctx, true);
        }

        static uint32_t decode_uavcan_protocol_AccessCommandShell_res(CanardRxTransfer transfer, uavcan_protocol_AccessCommandShell_res msg) {
            uint32_t bit_ofs = 0;
            _decode_uavcan_protocol_AccessCommandShell_res(transfer, ref bit_ofs, msg, true);
            return (bit_ofs+7)/8;
        }

        static void _encode_uavcan_protocol_AccessCommandShell_res(uint8_t[] buffer, uavcan_protocol_AccessCommandShell_res msg, dronecan_serializer_chunk_cb_ptr_t chunk_cb, object ctx, bool tao) {






            memset(buffer,0,8);

            canardEncodeScalar(buffer, 0, 32, msg.last_exit_status);

            chunk_cb(buffer, 32, ctx);





            memset(buffer,0,8);

            canardEncodeScalar(buffer, 0, 8, msg.flags);

            chunk_cb(buffer, 8, ctx);







            if (!tao) {


                memset(buffer,0,8);
                canardEncodeScalar(buffer, 0, 9, msg.output_len);
                chunk_cb(buffer, 9, ctx);


            }

            for (int i=0; i < msg.output_len; i++) {



                    memset(buffer,0,8);

                    canardEncodeScalar(buffer, 0, 8, msg.output[i]);

                    chunk_cb(buffer, 8, ctx);


            }





        }

        static void _decode_uavcan_protocol_AccessCommandShell_res(CanardRxTransfer transfer,ref uint32_t bit_ofs, uavcan_protocol_AccessCommandShell_res msg, bool tao) {








            canardDecodeScalar(transfer, bit_ofs, 32, true, ref msg.last_exit_status);


            bit_ofs += 32;








            canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.flags);


            bit_ofs += 8;








            if (!tao) {


                canardDecodeScalar(transfer, bit_ofs, 9, false, ref msg.output_len);
                bit_ofs += 9;



            } else {

                msg.output_len = (uint16_t)(((transfer.payload_len*8)-bit_ofs)/8);


            }



            msg.output = new uint8_t[msg.output_len];
            for (int i=0; i < msg.output_len; i++) {




                canardDecodeScalar(transfer, bit_ofs, 8, false, ref msg.output[i]);

                bit_ofs += 8;


            }







        }

    }

}
