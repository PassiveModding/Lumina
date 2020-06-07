using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestAnnounce", columnHash: 0xf8bddb48 )]
    public class DawnQuestAnnounce : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Quest;

        // col: 02 offset: 0004
        public uint[] ENPC;

        // col: 01 offset: 001c
        public byte Content;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            ENPC = new uint[6];
            ENPC[0] = parser.ReadOffset< uint >( 0x4 );
            ENPC[1] = parser.ReadOffset< uint >( 0x8 );
            ENPC[2] = parser.ReadOffset< uint >( 0xc );
            ENPC[3] = parser.ReadOffset< uint >( 0x10 );
            ENPC[4] = parser.ReadOffset< uint >( 0x14 );
            ENPC[5] = parser.ReadOffset< uint >( 0x18 );

            // col: 1 offset: 001c
            Content = parser.ReadOffset< byte >( 0x1c );


        }
    }
}