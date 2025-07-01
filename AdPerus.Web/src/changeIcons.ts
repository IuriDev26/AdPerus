function changeIcons() {
    console.log("Iniciando changeIcons");
    
    const menuItems = document.querySelectorAll(".menu-list-item");
    console.log(`Encontrados ${menuItems.length} itens de menu`);

    menuItems.forEach((item, index) => {
        const defaultIcon = item.querySelector(".default-icon") as HTMLImageElement;
        const hoverIcon = item.querySelector(".hover-icon") as HTMLImageElement;

        if (defaultIcon && hoverIcon) {
            console.log(`Configurando item ${index}`);
            
            item.addEventListener("mousedown", () => {
                defaultIcon.style.display = "none";
                hoverIcon.style.display = "inline";
            });

            item.addEventListener("mouseup", () => {
                defaultIcon.style.display = "inline";
                hoverIcon.style.display = "none";
            });
        }
    });
}

function initializeAfterBlazor() {
    if ('Blazor' in window) {
        changeIcons();
    } else {
        window.addEventListener('load', () => {
            setTimeout(changeIcons, 500); 
        });
    }
}

initializeAfterBlazor();

const observer = new MutationObserver(() => {
    changeIcons();
});

observer.observe(document.body, {
    childList: true,
    subtree: true
});