using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesSyncModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesSyncModel : AlipayObject
    {
        /// <summary>
        /// 欲升级的站点 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲升级的站点所归属的空间 ID
        /// </summary>
        [JsonProperty("space_id")]
        public string SpaceId { get; set; }
    }
}
