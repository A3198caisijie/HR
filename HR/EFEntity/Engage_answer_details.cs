using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class Engage_answer_details//考试答题详细信息
    {
        //       and_id smallint identity not null,答案详细信息
        [Key]
        public int and_id { get; set; }
        //   answer_number varchar(30) null,答案编号
        public string answer_number { get; set; }
        //subject_id smallint null,试题编号
        public int subject_id { get; set; }
        //   answer varchar(10) null,答题者答案
        public string answer { get; set; }
    }
}
