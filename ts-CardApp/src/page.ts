import CardService from "./card-service";

export default class Page
{
    cardContainer: HTMLElement | null = null;
    newDeck: HTMLElement | null = null;
    drawCard: HTMLElement |null = null;
    cardService: CardService;

    constructor(cardService: CardService)
    {
        this.cardService = cardService;
        document.addEventListener('DOMContentLoaded', () =>
        {
            this.cardContainer = document.getElementById('card-container');
            this.newDeck = document.getElementById('new-deck');
            this.drawCard = document.getElementById('draw-card');
        });
    }

    run() {
        document.addEventListener('DOMContentLoaded', () =>
        {

            this.newDeck?.addEventListener('click', () =>
            {

                while (this.cardContainer?.firstElementChild)
                {
                    this.cardContainer?.firstElementChild.remove();
                }

                this.cardService.newDeck().catch((error: Error) =>
                {
                });
            });

            this.drawCard?.addEventListener('click', () =>
            {
                this.cardService.drawCard().then(card =>
                {
                    const image = document.createElement('img');
                    image.src = card.image;
                    image.alt = card.code;
                    this.cardContainer?.appendChild(image);
                }, (error: Error) =>
                {
                });
            });
        });
    }
}