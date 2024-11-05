using System.ComponentModel.DataAnnotations;

namespace AuthenCardUI.Models
{
    public class Claim1
    {
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")]        
        public string pid {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string claimType {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string mobile {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string correlationId {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string hn {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string hcode {get; set;}
        [Required(ErrorMessage = "จำเป็นต้องกรอกข้อมูลให้ครบ")] 
        public string name {get; set;}
        public DateOnly? birthday { get; set; }
        public int age {get; set;}
    }
}