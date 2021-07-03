(function($){

		NinjaContactFormOpts.callbacks = {
			noop: function(){},"id1" : function(){}		}

		var insertListener = function(event){
			if (event.animationName == "bodyArrived") {
				afterBodyArrived();
			}
		}
		var timer;

		if (document.addEventListener && false) {
			document.addEventListener("animationstart", insertListener, false); // standard + firefox
			document.addEventListener("MSAnimationStart", insertListener, false); // IE
			document.addEventListener("webkitAnimationStart", insertListener, false); // Chrome + Safari
		} else {
			timer = setInterval(function(){
				if (document.body) {
					clearInterval(timer);
					afterBodyArrived();
				}
			},14);
		}

		function afterBodyArrived () {

			if (!window.NinjaContactFormOpts || window.NinjaSidebar) return;

			var opts = window.NinjaContactFormOpts;
			var nksopts = window.NKS_CC_Opts;
			var subopts = window.NKSubOpts;
			var $body = $('body');

			var TYPE = NinjaContactFormOpts.sidebar_type;
			var $bodybg = $('<div id="ncf-body-bg"/>').prependTo($body);
			var b = document.body;
			var bodyCss;

			// fix onload
			$(function(){
				setTimeout(function() {

					if (!$bodybg.parent().is($body)) {
						$body.prepend($bodybg).prepend($('.nks_cc_trigger_tabs')).prepend($('#ncf_sidebar')).append($('#ncf-overlay-wrapper'));
					}

					if (TYPE === 'push') { $bodybg.css('backgroundColor', $body.css('backgroundColor')) }

				},0)
			})

			if (TYPE === 'push') {

				bodyCss = {
					'backgroundColor':$body.css('backgroundColor'),
					'backgroundImage':$body.css('backgroundImage'),
					'backgroundAttachment':$body.css('backgroundAttachment'),
					'backgroundSize':$body.css('backgroundSize'),
					'backgroundPosition':$body.css('backgroundPosition'),
					'backgroundRepeat':$body.css('backgroundRepeat'),
					'backgroundOrigin':$body.css('backgroundOrigin'),
					'backgroundClip':$body.css('backgroundClip')
				};

				if (bodyCss.backgroundColor.indexOf('(0, 0, 0, 0') + 1 || bodyCss.backgroundColor.indexOf('transparent') + 1 ) {
					bodyCss.backgroundColor = '#fff';
				}

				if (bodyCss.backgroundAttachment === 'fixed') {
					NinjaContactFormOpts.isBgFixed = true;
					bodyCss.position = 'fixed';
					bodyCss.bottom = 0;
					bodyCss.backgroundAttachment = 'scroll';
				} else {
					bodyCss.height = Math.max(
						b.scrollHeight, document.documentElement.scrollHeight,
						b.offsetHeight, document.documentElement.offsetHeight,
						b.clientHeight, document.documentElement.clientHeight
					)
				}

				$bodybg.css(bodyCss);

			} else {
				//$body.addClass('nks_sidebar_slide')
			}

			setTimeout(function(){
				$(function(){

					var $tabs = $('.nks_cc_trigger_tabs');
					var $btn;
					var sel;
					var nkspos = nksopts && nksopts.sidebar_pos;
					var subpos = subopts && subopts.sidebar_pos;

					if ( $tabs.length && (opts.sidebar_pos === nkspos || opts.sidebar_pos === subpos) ) {

						$btn = $('<span class="fa-stack fa-lg ncf-tab-icon fa-2x"> <i class="fa ncf-icon-square fa-stack-2x "></i> <i class="fa ncf-icon-mail-1 fa-stack-1x fa-inverse"></i> </span>');

						if (opts.sidebar_pos === nkspos) {
							$tabs.filter(':has(".nks-tab")').prepend($btn);
							triggerEvent();
							return;
						}

						if (opts.sidebar_pos === subpos) {
							$tabs.filter(':has(".nksub-tab-icon")').prepend($btn);
							triggerEvent();
							return;
						}


					} else {
						$tabs = $('<div class="nks_cc_trigger_tabs ncf_tab ncf_label_scroll nks_metro"><span class="fa-stack ncf-tab-icon fa-lg fa-2x"> <i class="fa ncf-icon-square fa-stack-2x "></i> <i class="fa ncf-icon-mail-1 fa-stack-1x fa-inverse"></i> </span></div>');
						$body.append($tabs);
					}

					triggerEvent();
	//
				});
			});
		}

		function triggerEvent(){
				$(document).trigger('ncf_ready');
		}

	})(jQuery)
