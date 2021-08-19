using System;
using System.Collections.Generic;

namespace CP380_B1_BlockList.Models
{
    public class BlockList
    {
        public IList<Block> Chain { get; set; }

        public int Difficulty { get; set; } = 2;

        public BlockList()
        {
            Chain = new List<Block>();
            MakeFirstBlock();
        }

        public void MakeFirstBlock()
        {
            var block = new Block(DateTime.Now, null, new List<Payload>());
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public void AddBlock(Block block)
        {
            int c_length = Chain.Count-1;
            block.PreviousHash = Chain[c_length].Hash;
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public bool IsValid()
        {
            // TODO
             for ( var j = 1; j < Chain.Count; j++)
            {
                if (!Chain[j].Hash.StartsWith("CC"))
                {
                    return(false);

                }
            }

            return false;
        }
    }
}
