using MvcAreaHosting.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;

namespace MvcAreaHosting.BaseModels.Content
{
    public abstract class PictureType
    {
        public int PictureTypeID { get; set; }

        public string TypeName { get; set; }
    }

    public abstract class PictureResource
    {
        /// <summary>
        /// GUID ensures that pictures can't easily be trawled
        /// </summary>
        public Guid PictureResourceID { get; set; }

        [ForeignKey("TypeID")]
        public PictureType Type { get; set; }


    }
}