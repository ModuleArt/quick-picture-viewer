document.addEventListener("DOMContentLoaded", function () {
  let script = document.createElement("script");
  script.src = "js/particles.min.js";
  script.onload = function () {
    let month = new Date().getMonth();
    if (month == 0 || month == 10 || month == 11) {
      particlesJS("special-effects", {
        particles: {
          number: {
            value: 50,
            density: {
              enable: true,
              value_area: 800,
            },
          },
          color: {
            value: "#ffffff",
          },
          opacity: {
            value: 0.5,
            random: false,
            anim: {
              enable: false,
            },
          },
          size: {
            value: 4,
            random: true,
            anim: {
              enable: false,
            },
          },
          line_linked: {
            enable: false,
          },
          move: {
            enable: true,
            speed: 1, //speed of snowflakes
            direction: "bottom",
            random: true,
            straight: false,
            out_mode: "out",
            bounce: false,
            attract: {
              enable: true,
              rotateX: 300,
              rotateY: 1200,
            },
          },
        },
        interactivity: {
          events: {
            onhover: {
              enable: false,
            },
            onclick: {
              enable: false,
            },
            resize: true,
          },
        },
        retina_detect: true,
      });
    }
  };
  document.body.append(script);
});
