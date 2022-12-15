// More Apps
$( document ).ready(function () {
        $("#service-items li").slice(0, 7).show();
        if ($("#service-items li:hidden").length != 0) {
            $("#loadMore").show();
        }       
        $("#loadMore").on('click', function (e) {
            e.preventDefault();
            $("#service-items li:hidden").slice(0, 4).slideDown();
            if ($("#service-items li:hidden").length == 0) {
                $("#loadMore").fadeOut('slow');
            }
        });
    });

// Funfact
    jQuery('.funfact-number').each(function() {
        var $this = jQuery(this);
        var parts = $this.text().match(/^(\d+)(.*)/);
        if (parts.length < 2) return;
      
        var scale = 20;
        var delay = 50;
        var end = 0+parts[1];
        var next = 0;
        var suffix = parts[2];
        
        var runUp = function() {
          var show = Math.ceil(next);
          $this.text(''+show+suffix);
          if (show == end) return;
          next = next + (end - next) / scale;
          window.setTimeout(runUp, delay);
        }
        runUp();
    });


// Map
jQuery(document).ready(function () {
        jQuery('#vmap').vectorMap({
          map: 'world_en',
          backgroundColor: '#ffffff',
          color: '#ffffff',
          hoverOpacity: 0.7,
          selectedColor: '#666666',
          enableZoom: true,
          showTooltip: true,
          scaleColors: ['#C8EEFF', '#006491'],
          values: sample_data,
          normalizeFunction: 'polynomial'
        });
      });


// Projects carousel

$('.projects-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav: false,
    autoplay:true,
    dots:true,
    responsiveClass:true,
    responsive:{
        0:{
            items:1,
            nav:true
        },
        600:{
            items:1,
            nav:false
        },
        1000:{
            items:1,
            nav:true,
            loop:false
        }
    }
})


// 

$(document).ready(function() {
 
  var mockupSlider = $("#mockup-slider");
  var mockupSliderTitles = $("#mockup-slider-titles");
 
  mockupSlider.owlCarousel({
      singleItem:true,
      autoPlay: false,
      navigation: false,
      pagination: false,
      mouseDrag: false,
      touchDrag: false
  });
 
  mockupSliderTitles.owlCarousel({
      singleItem:true,
      autoPlay: false,
      navigation: false,
      pagination: false,
      mouseDrag: false,
      touchDrag: false
  });
  
  $(".next").click(function(){
    mockupSlider.trigger('owl.next');
    mockupSliderTitles.trigger('owl.next');
  });
  $(".prev").click(function(){
    mockupSlider.trigger('owl.prev');
    mockupSliderTitles.trigger('owl.prev');
  });
 
});


// Background Images
        $('[data-img-src]').each(function () {
            var imgValue = $(this).data('img-src');
            $(this).css('background-image', 'url(' + imgValue + ')');
        });
