//Set iFrame Height //
function resizeIframe() {
  //obj.style.height = obj.contentWindow.document.body.scrollHeight + 'px';
  $('iframe').height($('iframe').contents().height());
}
//Hide PREVIOUS button when personal details is on display //
var prevBtn = document.getElementById("prevBtn");
$(document).ready(function(){
  prevBtn.hidden = true;
});
function hidePrevButton(){
  prevBtn.hidden = true;
}
function showPrevButton(){
  prevBtn.hidden = false;
}

 //Input Masking //
 $(':input').inputmask();

 //Upload image in box/div on button click//
 $("input[name=img]").change(function () {
  if (this.files && this.files[0]) {
      var reader = new FileReader();

      reader.onload = function (e) {
          var img = $('<img>').attr('src', e.target.result);
          $('#display_image').html(img);
      };
      reader.readAsDataURL(this.files[0]);
  }
});
//Remove Image on button click //
var defaultImage = document.getElementById("profile_pic");
var uploadedImage = document.getElementById("image_input");
removeImage=()=>{
  var img = defaultImage;
  $('#display_image').html(img);
  uploadedImage.value = '';
}

//Hide elements at DOM loading //
$(document).ready(function(){
  document.getElementById('contactDetails').style.display = "none";
});
$(document).ready(function(){
  document.getElementById('educationDetails').style.display = "none";
});

//Show - Hide section on button click //

///Show section on Button Click - Plus Button
function showSection(sectionID)
{
  document.getElementById(sectionID).style.display = "block";
}
///Hide section on Button Click - Cancel Button
function hideSection(sectionID){
  let sectionToHide = document.getElementById(sectionID);
  sectionToHide.style.display = "none";
}