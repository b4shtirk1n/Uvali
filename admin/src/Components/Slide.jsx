import analytics from "../assets/analytics.svg";
import results from "../assets/result.svg";
import users from "../assets/users.svg";
import settings from "../assets/settings.svg";
import exit from "../assets/exit.svg";
import "../styles/Slide.scss";

export default function Slide() {
  return (
    <div className="slide">
      <div className="slide-top">
        <div className="slide-button">
          <img src={analytics} />
          <a href="#">Аналитика</a>
        </div>
        <div className="slide-button">
          <img src={results} />
          <a href="#">Результаты</a>
        </div>
        <div className="slide-button">
          <img src={users} />
          <a href="#">Пользователи</a>
        </div>
        <div className="slide-button">
          <img src={settings} />
          <a href="#">Настройки</a>
        </div>
      </div>
      <div className="slide-button">
        <img src={exit} />
        <a href="#">Выход</a>
      </div>
    </div>
  );
}
