var con = document.getElementById('conClose');
var per = document.getElementById('perClose');
var authen = document.getElementById('auClose');

con.addEventListener('click',function(){
    const cClose = document.querySelector('.contact-details');
    cClose.classList.add('hide');
});

document.getElementById('conEdit').addEventListener('click',function(){
    const cClose = document.querySelector('.contact-details');
    cClose.classList.remove('hide');
});

per.addEventListener('click',function(){
    const cClose = document.querySelector('.personal-details');
    cClose.classList.add('hide');
});

document.getElementById('perEdit').addEventListener('click',function(){
    const cClose = document.querySelector('.personal-details');
    cClose.classList.remove('hide');
});

authen.addEventListener('click',function(){
    const cClose = document.querySelector('.Authen-details');
    cClose.classList.add('hide');
});

document.getElementById('authEdit').addEventListener('click',function(){
    const cClose = document.querySelector('.Authen-details');
    cClose.classList.remove('hide');
});