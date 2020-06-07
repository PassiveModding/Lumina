using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountFlyingCondition", columnHash: 0xdbf43666 )]
    public class MountFlyingCondition : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Quest;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );


        }
    }
}