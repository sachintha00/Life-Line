let selection = document.getElementById('selectRoll');
let tblStudent = document.getElementById('tblStudent');
let tblTeacher = document.querySelector('tblTeacher');

selection.addEventListener('change',()=>{
    if(selection.options[selection.selectedIndex].text == 'Student'){
        tblTeacher.style.transform = "scale(0)";
        tblStudent.style.transform = "scale(1)";
    }
    if(selection.options[selection.selectedIndex].text == 'Teacher'){
        tblStudent.style.transform = "scale(0)";
        tblTeacher.style.transform = "scale(1)";
    }
});