use std::io;

fn main() {
    println!("Hello, world!");
    let mut my_str1 = String::new();
    io::stdin().read_line(&mut my_str1).expect("Error reading");
    let my_str2 = String::from("这是一个关于CSharp委托相关的知识点和练习代码的文件夹！！！");
    println!("{1}{0}", my_str1, my_str2);
}
