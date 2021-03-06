import {
  Component,
  OnInit,
  Input,
  Output,
  ViewEncapsulation,
  EventEmitter
} from "@angular/core";

@Component({
  selector: "app-card-list-item",
  templateUrl: "./card-list-item.component.html",
  styleUrls: ["./card-list-item.component.scss"],
  encapsulation: ViewEncapsulation.None
})
export class CardListItemComponent implements OnInit {
  @Input() cardItem: any;
  @Input() imageUrl: any;
  @Input() onClickPath: any;
  @Input() hasDelete: boolean;
  @Input() hasEdit: boolean;
  @Input() hasRating: boolean;
  @Input() handleRateChange: any;

  @Output() onDelete = new EventEmitter<number>();
  @Output() onEdit = new EventEmitter<number>();

  constructor() {}

  ngOnInit() {}

  handleDelete() {
    this.onDelete.emit(this.cardItem.id);
  }

  handleEdit() {
    this.onEdit.emit(this.cardItem);
  }
}
