using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookForBook.Models
{
    public class User
    {
        public User()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string State { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

           /* <div class="form-group">
        @Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" })
        </div>
    </div> */

       /*     <div class="form-group">
        @Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" })
        </div>
    </div>
    */

         /*    <div class="form-group">
        @Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-md-10">
            @Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } })
            @Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" })
        </div>
    </div> */

            /*  <dt>
            @Html.DisplayNameFor(model => model.Password)
        </dt>

        <dd>
            @Html.DisplayFor(model => model.Password)
        </dd>
        */
      /*  <td>
        @Html.DisplayNameFor(model => model.Password)
    </td> 
    */
        public virtual ICollection<Book> Books { get; set; }
    }
}