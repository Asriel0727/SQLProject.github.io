//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public int fId { get; set; }
        [DisplayName("商品編號")]

        public string pId { get; set; }
        [DisplayName("商品名稱")]
        public string pName { get; set; }
        [DisplayName("商品單價")]
        public int pPrice { get; set; }
        [DisplayName("商品類別")]
        public string pCategory { get; set; }
        [DisplayName("歌手")]
        public string pSinger { get; set; }
        [DisplayName("商品圖")]
        public string Pimg { get; set; }
    }
}
