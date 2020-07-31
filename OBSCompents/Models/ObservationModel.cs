using System;
using System.Collections.Generic;
using System.Text;

namespace OBSCompents.Models
{
    public class ObservationGroupModel
    {
        public int GrpId { get; set; }
        public string GrpText { get; set; }
    }
    public class MetaItemModel
    {
        public int ItemId { get; set; }
        public string ItemText { get; set; }
    }
    public class ObservationModel
    {
        public int ObsId { get; set; }
        public string ObsText { get; set; }
    }
    public class ObservationViewModel
    {
        public int GrpId { get; set; }
        public string GrpText { get; set; }
        public List<ObservationModel> observations { get; set; }
        public List<ResponseTypeModel> responseTypes { get; set; }
    }
    public class ResponseModel
    {
        public int GrpId { get; set; }
        public int ObsId { get; set; }
        public int Response { get; set; }
        public string Comment { get; set; }
    }
    public class ResponseTypeModel
    {
        public int ResponseId { get; set; }
        public string ResponseText { get; set; }
    }
}
