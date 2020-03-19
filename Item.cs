namespace DataTriageTransferTool
{
    class Item
    {
        public int CaseNumber;
        public string Make;
        public string Model;
        public string Size;
        public int SizeType_ID;
        public string SerialNumber;
        public string IMEI;
        public string ICCID;
        public string IMSI;
        public string SubscriberAccount;
        public string Comments;
        public static int Sent;
        public static int Zipped;
        public static int Open;
        public string ClosedDate;
        public string UpdatedDate;
        public string SubmittedDate;
        public string Type;
        public bool isMedex;
        public bool isMobile;
        public bool isSim;
        public bool isSubItem;
        public int Parent_ID;
        public string folderName;
    }
}
