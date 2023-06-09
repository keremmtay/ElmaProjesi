
const lightSearch = (input, elements, options = {}) => {
  input.addEventListener('input', () => {
    let result = 0;

    for (const element of elements) {
      if (element.innerHTML.toLowerCase().includes(input.value.toLowerCase())) {
          element.style.display = options.display ? options.display : 'block';
          result++;

          if(options.onclick) {
            element.addEventListener('click', options.onclick);
          }

      } else {
          element.style.display = options.hide ? options.hide : 'none';
      }
    }

    if(options.displayontype) {
      if(input.value.length >= options.displayontype) {
        options.parent.style.display = options.displayparent ? options.displayparent : 'block';
      } else {
        options.parent.style.display = options.hideparent ? options.hideparent : 'none';
      }
    }

    if (options.noresultsmsg && options.parent) {
      const errormsg = document.querySelector('.light-search-noresults');

      if (!result) {
        const msgtag = options.msgtag ? options.msgtag : 'p';
        const msgtext = options.msgtext ? options.msgtext : 'No results found';

        const msgelement = document.createElement(msgtag);
              msgelement.innerHTML = msgtext;
              msgelement.classList.add('light-search-noresults');

        if (!errormsg) {
          options.parent.appendChild(msgelement);
        }
      } else {
        if (errormsg) {
          errormsg.remove();
        }
      }
    }
  });
}
