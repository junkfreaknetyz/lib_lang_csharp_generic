using System;

namespace lang.generic.common{
    public class File{

        private String file_name;
        
        public File(String para){
            this.file_name=para;
        }
        public File(File para){
            this.file_name=para.Get();
        }
        public void Set(String para){
            this.file_name=para;
        }
        public void Set(File para){
            this.file_name=para.file_name;
        }
        public String Get(){
            return this.file_name;
        }
    }
}