using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantScreenHit Data Structure.
    /// </summary>
    public class MerchantScreenHit : AlipayObject
    {
        /// <summary>
        /// 送检的实体类型，如CEO，控股人，等
        /// </summary>
        [JsonProperty("input_type")]
        public string InputType { get; set; }

        /// <summary>
        /// 命中详情
        /// </summary>
        [JsonProperty("risk_detail")]
        public string RiskDetail { get; set; }
    }
}
