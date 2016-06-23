#region copyright
// <copyright file="BlocksRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
namespace LiskSharp.Core.Api
{
    /// <summary>
    /// BlocksRequest used when retrieving more than one blocks
    /// /api/blocks
    /// </summary>
    public class BlocksRequest : BaseRequest
    {
        public string GeneratorPublickey { get; set; }

        public long? TotalAmount { get; set; }

        public int? TotalFee { get; set; }

        public int? Reward { get; set; }

        public string PreviousBlock { get; set; }

        public int? Height { get; set; }


        public override string ToQuery()
        {
            if (!string.IsNullOrWhiteSpace(GeneratorPublickey))
            {
                QueryParams.Add($"generatorpublickey={GeneratorPublickey}");
            }

            if (TotalAmount.HasValue)
            {
                QueryParams.Add($"totalAmount={TotalAmount}");
            }

            if (TotalFee.HasValue)
            {
                QueryParams.Add($"totalFee={TotalFee}");
            }

            if (Reward.HasValue)
            {
                QueryParams.Add($"reward={Reward}");
            }

            if (!string.IsNullOrWhiteSpace(PreviousBlock))
            {
                QueryParams.Add($"previousBlock={PreviousBlock}");
            }

            if (Height.HasValue)
            {
                QueryParams.Add($"height={Height}");
            }

            return base.ToQuery();
        }
    }
}
