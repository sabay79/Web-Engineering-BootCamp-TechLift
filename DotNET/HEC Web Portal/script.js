// $(document).ready(function(){
// });

// $('#nav-personal-tab').on('click', function(event) {        
//    document.getElementById("nav-personal").setAttribute('hidden', false)
// });

// $('#nav-contact-tab').on('click', function(event) {        
//    document.getElementById("nav-contact").setAttribute('hidden', false)
// });

// $('#nav-edu-tab').on('click', function(event) {        
//    document.getElementById("nav-edu").setAttribute('hidden', false)
// });

// $('#nav-emp-tab').on('click', function(event) {        
//    document.getElementById("nav-emp").setAttribute('hidden', false)
// });

// $(".tab").click(function () {
//     $(".tab").removeClass("active");
//     // $(".tab").addClass("active"); // instead of this do the below 
//     $(this).addClass("active");   
// });

// $('#about').setAttribute('hidden', true)
//Set iFrame Height
function resizeIframe() {

   //obj.style.height = obj.contentWindow.document.body.scrollHeight + 'px';
   $('iframe').height($('iframe').contents().height());

 }