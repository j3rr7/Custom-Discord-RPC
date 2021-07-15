using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace DiscordRPC
{
    public class CustomRPCManager
    {
        public string app_id { get; set; }
        public string custom_state { get; set; }
        public string custom_details { get; set; }
        public UInt64 start_timestamp { get; set; }
        public UInt64 end_timestamp { get; set; }
        public string large_image_key { get; set; }
        public string large_image_text { get; set; }
        public string small_image_key { get; set; }
        public string small_image_text { get; set; }
        public bool extra_enabled { get; set; }

        // Blank Constructor
        public CustomRPCManager()
        {
            Clear();
        }

        public void Clear()
        {
            this.app_id = "";
            this.custom_state = "";
            this.custom_details = "";
            this.start_timestamp = 0;
            this.end_timestamp = 0;
            this.large_image_key = this.large_image_text = this.small_image_key = this.small_image_text = "";
            extra_enabled = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}